# Fact ba346939

Store id: acf008b9-9f40-470a-b0c0-2548b8da262f

## Text

```text
def __init__(self, sqls, params)
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
- posted_at: `2026-11-09T22:39:51.9920160+00:00`

## Data

```json
{
  "end_line": 341,
  "entity_kind": "method",
  "parent": "ExtraWhere",
  "start_line": 339,
  "symbol": "ExtraWhere.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":339,"selector":"L339-L341","symbol":"ExtraWhere.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::ExtraWhere.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 341,
    "entity_kind": "method",
    "parent": "ExtraWhere",
    "start_line": 339,
    "symbol": "ExtraWhere.__init__"
  },
  "id": "acf008b9-9f40-470a-b0c0-2548b8da262f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9920160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 339,
        "selector": "L339-L341",
        "symbol": "ExtraWhere.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "2a634d1c-2901-44c8-9044-c5e0d330b94d",
  "subject_name": "django/db/models/sql/where::ExtraWhere.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, sqls, params)"
}
```
