# Fact 9f3841d8

Store id: bc6bef5e-cfbe-42ea-ad00-d7f74cb348e0

## Text

```text
def select_format(self, compiler, sql, params)
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
- posted_at: `2026-11-09T23:32:07.6900590+00:00`

## Data

```json
{
  "end_line": 308,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 302,
  "symbol": "WhereNode.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":302,"selector":"L302-L308","symbol":"WhereNode.select_format"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 308,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 302,
    "symbol": "WhereNode.select_format"
  },
  "id": "bc6bef5e-cfbe-42ea-ad00-d7f74cb348e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6900590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 302,
        "selector": "L302-L308",
        "symbol": "WhereNode.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "bda002f5-a1a5-4a34-83e4-49959ae1d17b",
  "subject_name": "django/db/models/sql/where::WhereNode.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
