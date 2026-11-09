# Fact 88522779

Store id: a62f56b6-7fac-44f2-9d7d-6e8e133307b8

## Text

```text
def get_related_klass_infos(klass_info, related_klass_infos)
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
- posted_at: `2026-11-09T22:39:50.6419390+00:00`

## Data

```json
{
  "end_line": 1239,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_related_selections",
  "start_line": 1238,
  "symbol": "SQLCompiler.get_related_selections.get_related_klass_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1238,"selector":"L1238-L1239","symbol":"SQLCompiler.get_related_selections.get_related_klass_infos"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections.get_related_klass_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1239,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_related_selections",
    "start_line": 1238,
    "symbol": "SQLCompiler.get_related_selections.get_related_klass_infos"
  },
  "id": "a62f56b6-7fac-44f2-9d7d-6e8e133307b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6419390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1238,
        "selector": "L1238-L1239",
        "symbol": "SQLCompiler.get_related_selections.get_related_klass_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "27b54d10-6393-4c40-9cf1-2d1af13becf0",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections.get_related_klass_infos",
  "tags": [
    "entity:function"
  ],
  "text": "def get_related_klass_infos(klass_info, related_klass_infos)"
}
```
