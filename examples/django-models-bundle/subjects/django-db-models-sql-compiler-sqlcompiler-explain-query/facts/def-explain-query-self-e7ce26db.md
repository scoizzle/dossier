# Fact e7ce26db

Store id: 5a9287e0-ed3f-41f5-9379-cc8c408a63ca

## Text

```text
def explain_query(self)
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
- posted_at: `2026-11-09T23:44:57.6404090+00:00`

## Data

```json
{
  "end_line": 1698,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1687,
  "symbol": "SQLCompiler.explain_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1687,"selector":"L1687-L1698","symbol":"SQLCompiler.explain_query"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.explain_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1698,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1687,
    "symbol": "SQLCompiler.explain_query"
  },
  "id": "5a9287e0-ed3f-41f5-9379-cc8c408a63ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6404090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1687,
        "selector": "L1687-L1698",
        "symbol": "SQLCompiler.explain_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "c5473c50-3b17-4d2f-98ec-46540ef5f0e5",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.explain_query",
  "tags": [
    "entity:method"
  ],
  "text": "def explain_query(self)"
}
```
