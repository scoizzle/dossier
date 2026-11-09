# Fact cf95d339

Store id: 10dbec04-f552-4cae-91ec-40a9a3b6e489

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
- posted_at: `2026-11-09T23:44:51.4779480+00:00`

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
  "id": "10dbec04-f552-4cae-91ec-40a9a3b6e489",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4779480+00:00"
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
  "subject_id": "a77675e4-3aa0-4176-9ff6-6feeb672e8e1",
  "subject_name": "django/db/models/fields/related::RelatedField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False, **kwargs)"
}
```
