# Fact e7ce26db

Store id: ecdc4421-faad-4df6-9975-e374f5fca382

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
- posted_at: `2026-11-09T22:39:50.6850390+00:00`

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
  "id": "ecdc4421-faad-4df6-9975-e374f5fca382",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6850390+00:00"
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
  "subject_id": "06302f78-73ae-4205-93b6-ba3a3bc5e4f6",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.explain_query",
  "tags": [
    "entity:method"
  ],
  "text": "def explain_query(self)"
}
```
