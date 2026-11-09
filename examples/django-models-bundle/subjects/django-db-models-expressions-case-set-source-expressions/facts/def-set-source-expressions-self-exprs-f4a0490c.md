# Fact f4a0490c

Store id: ba3c2650-748c-4fd5-8f4b-be23bd9e9a70

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.6277470+00:00`

## Data

```json
{
  "end_line": 1754,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1753,
  "symbol": "Case.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1753,"selector":"L1753-L1754","symbol":"Case.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1754,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1753,
    "symbol": "Case.set_source_expressions"
  },
  "id": "ba3c2650-748c-4fd5-8f4b-be23bd9e9a70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6277470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1753,
        "selector": "L1753-L1754",
        "symbol": "Case.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a20607b8-97c3-4f4e-8000-393bf6218020",
  "subject_name": "django/db/models/expressions::Case.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
