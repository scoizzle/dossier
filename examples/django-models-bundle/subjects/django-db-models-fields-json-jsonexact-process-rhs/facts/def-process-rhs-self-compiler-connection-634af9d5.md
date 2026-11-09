# Fact 634af9d5

Store id: 36c23589-379b-48e3-b9d0-17670bd97b7b

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
- posted_at: `2026-11-09T23:31:57.9281910+00:00`

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
  "id": "36c23589-379b-48e3-b9d0-17670bd97b7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9281910+00:00"
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
  "subject_id": "921f2f2b-a3fb-4ca7-bf0e-4fd52b678f11",
  "subject_name": "django/db/models/fields/json::JSONExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
