# Fact 354063e3

Store id: 4e36bd76-16d4-44ad-a9d0-c0acf8934a31

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
- posted_at: `2026-11-09T23:44:57.4841700+00:00`

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
  "id": "4e36bd76-16d4-44ad-a9d0-c0acf8934a31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4841700+00:00"
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
  "subject_id": "cf5c8af8-032f-4edf-b58f-295c6d1e28c5",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.compile",
  "tags": [
    "entity:method"
  ],
  "text": "def compile(self, node)"
}
```
