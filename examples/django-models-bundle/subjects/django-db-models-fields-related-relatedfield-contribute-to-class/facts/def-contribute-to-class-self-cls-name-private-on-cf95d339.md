# Fact cf95d339

Store id: fa041410-009c-46ef-9f1f-6532f697abf8

## Text

```text
def contribute_to_class(self, cls, name, private_only=False, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.2641760+00:00`

## Data

```json
{
  "end_line": 407,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 376,
  "symbol": "RelatedField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":376,"selector":"L376-L407","symbol":"RelatedField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 407,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 376,
    "symbol": "RelatedField.contribute_to_class"
  },
  "id": "fa041410-009c-46ef-9f1f-6532f697abf8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2641760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 376,
        "selector": "L376-L407",
        "symbol": "RelatedField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "3e43a516-351a-4ab2-9f3f-a906940f83bb",
  "subject_name": "django/db/models/fields/related::RelatedField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False, **kwargs)"
}
```
