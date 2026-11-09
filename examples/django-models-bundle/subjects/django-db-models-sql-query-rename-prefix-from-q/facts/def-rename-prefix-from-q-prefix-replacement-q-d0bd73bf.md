# Fact d0bd73bf

Store id: d9da04cd-dd1d-480e-8e2f-6d717e73d4af

## Text

```text
def rename_prefix_from_q(prefix, replacement, q)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.6911180+00:00`

## Data

```json
{
  "end_line": 146,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 141,
  "symbol": "rename_prefix_from_q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L146","symbol":"rename_prefix_from_q"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::rename_prefix_from_q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 146,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 141,
    "symbol": "rename_prefix_from_q"
  },
  "id": "d9da04cd-dd1d-480e-8e2f-6d717e73d4af",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.6911180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L146",
        "symbol": "rename_prefix_from_q"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "65433d24-6ed9-47c0-914b-f58d60a723cc",
  "subject_name": "django/db/models/sql/query::rename_prefix_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def rename_prefix_from_q(prefix, replacement, q)"
}
```
