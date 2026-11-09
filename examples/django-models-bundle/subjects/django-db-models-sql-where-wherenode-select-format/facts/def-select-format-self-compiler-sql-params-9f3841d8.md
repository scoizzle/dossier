# Fact 9f3841d8

Store id: 6f8c29ff-664e-4905-af7c-d51544f9eae7

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
- posted_at: `2026-11-09T22:39:51.9688240+00:00`

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
  "id": "6f8c29ff-664e-4905-af7c-d51544f9eae7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9688240+00:00"
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
  "subject_id": "326fec70-aec0-4d7a-b002-2340106e9935",
  "subject_name": "django/db/models/sql/where::WhereNode.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
