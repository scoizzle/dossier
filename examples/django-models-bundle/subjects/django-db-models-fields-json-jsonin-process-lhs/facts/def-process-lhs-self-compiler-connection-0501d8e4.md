# Fact 0501d8e4

Store id: 6cce6864-8cc1-4166-8b0f-a9297e8f0bbe

## Text

```text
def process_lhs(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6986060+00:00`

## Data

```json
{
  "end_line": 462,
  "entity_kind": "method",
  "parent": "JSONIn",
  "start_line": 445,
  "symbol": "JSONIn.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"selector":"L445-L462","symbol":"JSONIn.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 462,
    "entity_kind": "method",
    "parent": "JSONIn",
    "start_line": 445,
    "symbol": "JSONIn.process_lhs"
  },
  "id": "6cce6864-8cc1-4166-8b0f-a9297e8f0bbe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6986060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 445,
        "selector": "L445-L462",
        "symbol": "JSONIn.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "691641a3-e3f3-45e3-949c-8de4f75aaca5",
  "subject_name": "django/db/models/fields/json::JSONIn.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection)"
}
```
