# Fact 9f3841d8

Store id: e6762848-70d3-41d5-8c91-f095305fd922

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
- posted_at: `2026-11-09T23:44:59.8055450+00:00`

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
  "id": "e6762848-70d3-41d5-8c91-f095305fd922",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.8055450+00:00"
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
  "subject_id": "18187787-90ae-4528-a9a8-6e94946bfd0a",
  "subject_name": "django/db/models/sql/where::WhereNode.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
