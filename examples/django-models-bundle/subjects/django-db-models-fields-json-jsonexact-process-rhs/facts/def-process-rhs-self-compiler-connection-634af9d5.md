# Fact 634af9d5

Store id: 47707437-5853-4793-87f5-7b2dcabca54e

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6789920+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "JSONExact",
  "start_line": 320,
  "symbol": "JSONExact.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"selector":"L320-L342","symbol":"JSONExact.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONExact.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "JSONExact",
    "start_line": 320,
    "symbol": "JSONExact.process_rhs"
  },
  "id": "47707437-5853-4793-87f5-7b2dcabca54e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6789920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 320,
        "selector": "L320-L342",
        "symbol": "JSONExact.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "501a54ae-df7b-4d16-8fbe-779183650a50",
  "subject_name": "django/db/models/fields/json::JSONExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
