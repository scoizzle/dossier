# Fact c7d89812

Store id: 5824a4dc-1ea8-4c41-8169-f08a657fdf9a

## Text

```text
def _get_pk_val(self, meta=None)
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
- posted_at: `2026-11-09T23:31:53.7355150+00:00`

## Data

```json
{
  "end_line": 700,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 698,
  "symbol": "Model._get_pk_val"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":698,"selector":"L698-L700","symbol":"Model._get_pk_val"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_pk_val](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 700,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 698,
    "symbol": "Model._get_pk_val"
  },
  "id": "5824a4dc-1ea8-4c41-8169-f08a657fdf9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7355150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 698,
        "selector": "L698-L700",
        "symbol": "Model._get_pk_val"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "3655942b-c5cc-488a-b247-ccd3323a1e0d",
  "subject_name": "django/db/models/base::Model._get_pk_val",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_pk_val(self, meta=None)"
}
```
