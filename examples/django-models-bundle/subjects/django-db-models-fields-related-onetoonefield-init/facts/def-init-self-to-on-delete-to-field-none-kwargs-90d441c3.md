# Fact 90d441c3

Store id: ee4738c6-b83c-4df4-af82-6d6fd314bd6f

## Text

```text
def __init__(self, to, on_delete, to_field=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.4273340+00:00`

## Data

```json
{
  "end_line": 1373,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1371,
  "symbol": "OneToOneField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1371,"selector":"L1371-L1373","symbol":"OneToOneField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1373,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1371,
    "symbol": "OneToOneField.__init__"
  },
  "id": "ee4738c6-b83c-4df4-af82-6d6fd314bd6f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4273340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1371,
        "selector": "L1371-L1373",
        "symbol": "OneToOneField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "42ecc57c-b9a9-4f94-b5ef-2d3abb21ebcf",
  "subject_name": "django/db/models/fields/related::OneToOneField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, to, on_delete, to_field=None, **kwargs)"
}
```
