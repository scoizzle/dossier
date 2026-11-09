# Fact a1839bba

Store id: a95c8519-3a4d-4380-b4d4-7a75c08d89ef

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.2472400+00:00`

## Data

```json
{
  "end_line": 133,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 125,
  "symbol": "RelatedField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":125,"selector":"L125-L133","symbol":"RelatedField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 133,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 125,
    "symbol": "RelatedField.check"
  },
  "id": "a95c8519-3a4d-4380-b4d4-7a75c08d89ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2472400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 125,
        "selector": "L125-L133",
        "symbol": "RelatedField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ca6f35ee-86a5-4f72-886e-d639e1daa216",
  "subject_name": "django/db/models/fields/related::RelatedField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
