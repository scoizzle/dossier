# Fact d0bd73bf

Store id: 901df4b4-86c4-45df-87d9-287bba7b5200

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
- posted_at: `2026-11-09T23:44:58.5240040+00:00`

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
  "id": "901df4b4-86c4-45df-87d9-287bba7b5200",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5240040+00:00"
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
  "subject_id": "cb19d23a-13e2-4009-a4af-d82b44d1ff8b",
  "subject_name": "django/db/models/sql/query::rename_prefix_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def rename_prefix_from_q(prefix, replacement, q)"
}
```
