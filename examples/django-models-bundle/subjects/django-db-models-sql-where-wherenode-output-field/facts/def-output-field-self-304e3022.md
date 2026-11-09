# Fact 304e3022

Store id: e8567e2e-58d8-442e-a736-e631b0c5f077

## Text

```text
def output_field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.6793600+00:00`

## Data

```json
{
  "end_line": 296,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 292,
  "symbol": "WhereNode.output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":292,"selector":"L292-L296","symbol":"WhereNode.output_field"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 296,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 292,
    "symbol": "WhereNode.output_field"
  },
  "id": "e8567e2e-58d8-442e-a736-e631b0c5f077",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6793600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 292,
        "selector": "L292-L296",
        "symbol": "WhereNode.output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "1fd36ca3-30ee-40d9-a03f-66b92d98367c",
  "subject_name": "django/db/models/sql/where::WhereNode.output_field",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def output_field(self)"
}
```
