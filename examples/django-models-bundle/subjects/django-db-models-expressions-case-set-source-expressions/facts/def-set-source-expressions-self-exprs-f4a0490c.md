# Fact f4a0490c

Store id: eec28a6c-32a9-4be7-9373-03037298f3a2

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
- posted_at: `2026-11-09T23:31:55.9620090+00:00`

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
  "id": "eec28a6c-32a9-4be7-9373-03037298f3a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9620090+00:00"
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
  "subject_id": "28129c21-ef05-4e22-aa21-d51a2a3feb2f",
  "subject_name": "django/db/models/expressions::Case.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
