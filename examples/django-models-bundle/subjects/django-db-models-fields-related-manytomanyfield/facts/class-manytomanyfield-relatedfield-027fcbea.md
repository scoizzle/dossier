# Fact 027fcbea

Store id: d56d6e16-7887-4b5c-883c-ad478fd3f27f

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
- posted_at: `2026-11-09T23:31:58.8253700+00:00`

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
  "id": "d56d6e16-7887-4b5c-883c-ad478fd3f27f",
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
    "posted_at": "2026-11-09T23:31:58.8253700+00:00"
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
  "subject_id": "42ef2b96-d5fa-431c-82a6-55ba4fa22ede",
  "subject_name": "django/db/models/fields/related::ManyToManyField",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyToManyField(RelatedField)"
}
```
