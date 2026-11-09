# Fact 188b4ca9

Store id: 748f17d9-6aef-4fc0-8568-c3ef07354bc7

## Text

```text
def _output_field_or_none(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.9657660+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 298,
  "symbol": "WhereNode._output_field_or_none"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":298,"selector":"L298-L300","symbol":"WhereNode._output_field_or_none"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._output_field_or_none](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 298,
    "symbol": "WhereNode._output_field_or_none"
  },
  "id": "748f17d9-6aef-4fc0-8568-c3ef07354bc7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9657660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 298,
        "selector": "L298-L300",
        "symbol": "WhereNode._output_field_or_none"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "9b55d167-f87c-4c2a-a8c1-adadd14e2c9f",
  "subject_name": "django/db/models/sql/where::WhereNode._output_field_or_none",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _output_field_or_none(self)"
}
```
