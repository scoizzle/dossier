# Fact 027fcbea

Store id: 3f53d209-f0d3-4862-9bf1-93500af9f2f2

## Text

```text
class ManyToManyField(RelatedField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.4407490+00:00`

## Data

```json
{
  "end_line": 2212,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 1458,
  "symbol": "ManyToManyField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1458,"selector":"L1458-L2212","symbol":"ManyToManyField"}`

## Items

```json
[
  {
    "text": "Provide a many-to-many relation by using an intermediary model that holds two ForeignKey fields pointed at the two sides of the relation.",
    "locator": {
      "line": 1459
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2212,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 1458,
    "symbol": "ManyToManyField"
  },
  "id": "3f53d209-f0d3-4862-9bf1-93500af9f2f2",
  "items": [
    {
      "locator": {
        "line": 1459
      },
      "text": "Provide a many-to-many relation by using an intermediary model that holds two ForeignKey fields pointed at the two sides of the relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4407490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1458,
        "selector": "L1458-L2212",
        "symbol": "ManyToManyField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "7ee0be24-8273-4a13-840b-28c9ea537604",
  "subject_name": "django/db/models/fields/related::ManyToManyField",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyToManyField(RelatedField)"
}
```
