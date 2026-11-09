# Fact 7f99d706

Store id: 49c16ae3-74ad-45e7-a2dd-5182028b6369

## Text

```text
def target_field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.4987520+00:00`

## Data

```json
{
  "end_line": 537,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 525,
  "symbol": "RelatedField.target_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":525,"selector":"L525-L537","symbol":"RelatedField.target_field"}`

## Items

```json
[
  {
    "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen.",
    "locator": {
      "line": 527
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.target_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 537,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 525,
    "symbol": "RelatedField.target_field"
  },
  "id": "49c16ae3-74ad-45e7-a2dd-5182028b6369",
  "items": [
    {
      "locator": {
        "line": 527
      },
      "text": "When filtering against this relation, return the field on the remote model against which the filtering should happen."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4987520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 525,
        "selector": "L525-L537",
        "symbol": "RelatedField.target_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2bd2c038-7283-49f3-8fa6-ef091fb9be0f",
  "subject_name": "django/db/models/fields/related::RelatedField.target_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def target_field(self)"
}
```
