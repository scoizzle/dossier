# Fact 354063e3

Store id: 8509ea49-e682-4c26-8b90-cf35e8b3d3a4

## Text

```text
def compile(self, node)
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
- posted_at: `2026-11-09T22:39:50.6028960+00:00`

## Data

```json
{
  "end_line": 598,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 592,
  "symbol": "SQLCompiler.compile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":592,"selector":"L592-L598","symbol":"SQLCompiler.compile"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.compile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 598,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 592,
    "symbol": "SQLCompiler.compile"
  },
  "id": "8509ea49-e682-4c26-8b90-cf35e8b3d3a4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6028960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 592,
        "selector": "L592-L598",
        "symbol": "SQLCompiler.compile"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "18885193-3eda-4324-afbe-14b975176fca",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.compile",
  "tags": [
    "entity:method"
  ],
  "text": "def compile(self, node)"
}
```
