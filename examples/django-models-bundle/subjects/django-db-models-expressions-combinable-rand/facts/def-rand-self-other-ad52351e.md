# Fact ad52351e

Store id: f5792f17-c728-4c53-aa24-bb4bce5fa2e9

## Text

```text
def __rand__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2585850+00:00`

## Data

```json
{
  "end_line": 154,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 151,
  "symbol": "Combinable.__rand__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L154","symbol":"Combinable.__rand__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rand__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 154,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 151,
    "symbol": "Combinable.__rand__"
  },
  "id": "f5792f17-c728-4c53-aa24-bb4bce5fa2e9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2585850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L154",
        "symbol": "Combinable.__rand__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ab48ced9-d920-4a05-9deb-d6faf564cbe6",
  "subject_name": "django/db/models/expressions::Combinable.__rand__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rand__(self, other)"
}
```
