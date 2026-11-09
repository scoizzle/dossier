# Fact 354063e3

Store id: a557dd66-7f09-45a8-8114-4463112e0d65

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
- posted_at: `2026-11-09T23:32:05.7329120+00:00`

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
  "id": "a557dd66-7f09-45a8-8114-4463112e0d65",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7329120+00:00"
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
  "subject_id": "443babc6-23d7-4f9f-861e-d981ab0c9c11",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.compile",
  "tags": [
    "entity:method"
  ],
  "text": "def compile(self, node)"
}
```
