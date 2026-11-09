# Fact 0501d8e4

Store id: aebf0bcd-2523-4680-8289-8cf65088b4cc

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
- posted_at: `2026-11-09T23:44:51.0131560+00:00`

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
  "id": "aebf0bcd-2523-4680-8289-8cf65088b4cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0131560+00:00"
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
  "subject_id": "5020dc78-0d6c-422e-9951-56d757024dba",
  "subject_name": "django/db/models/fields/json::JSONIn.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection)"
}
```
