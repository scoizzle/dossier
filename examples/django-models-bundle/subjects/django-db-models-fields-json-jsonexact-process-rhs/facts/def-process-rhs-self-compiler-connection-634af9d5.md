# Fact 634af9d5

Store id: 03f83893-1255-460f-97ae-13eb5a422cc6

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
- posted_at: `2026-11-09T23:44:50.9955140+00:00`

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
  "id": "03f83893-1255-460f-97ae-13eb5a422cc6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9955140+00:00"
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
  "subject_id": "4df10201-ed05-4dc8-850a-f5cce7ecdddc",
  "subject_name": "django/db/models/fields/json::JSONExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
