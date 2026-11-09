# Fact d0bd73bf

Store id: fc57fae3-2a06-4d82-9e7a-808fd8226ae9

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
- posted_at: `2026-11-09T22:39:51.1761540+00:00`

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
  "id": "fc57fae3-2a06-4d82-9e7a-808fd8226ae9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1761540+00:00"
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
  "subject_id": "d7affc98-9582-4a9a-85fc-9e2fd5e0aabf",
  "subject_name": "django/db/models/sql/query::rename_prefix_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def rename_prefix_from_q(prefix, replacement, q)"
}
```
