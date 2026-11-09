# Fact bc7381a1

Store id: fce75a52-fbc2-4114-b685-4b2138f859d5

## Text

```text
def get_child_with_renamed_prefix(prefix, replacement, child)
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
- posted_at: `2026-11-09T22:39:51.1640650+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 105,
  "symbol": "get_child_with_renamed_prefix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":105,"selector":"L105-L138","symbol":"get_child_with_renamed_prefix"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_child_with_renamed_prefix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 105,
    "symbol": "get_child_with_renamed_prefix"
  },
  "id": "fce75a52-fbc2-4114-b685-4b2138f859d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1640650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 105,
        "selector": "L105-L138",
        "symbol": "get_child_with_renamed_prefix"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6d27e888-767d-4b15-a6bd-84aa224328f2",
  "subject_name": "django/db/models/sql/query::get_child_with_renamed_prefix",
  "tags": [
    "entity:function"
  ],
  "text": "def get_child_with_renamed_prefix(prefix, replacement, child)"
}
```
