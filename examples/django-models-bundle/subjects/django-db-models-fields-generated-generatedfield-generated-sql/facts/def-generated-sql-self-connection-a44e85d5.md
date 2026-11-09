# Fact a44e85d5

Store id: 7af27255-dd9b-4eb8-92b7-2694724101c9

## Text

```text
def generated_sql(self, connection)
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
- posted_at: `2026-11-09T22:39:43.4325670+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 54,
  "symbol": "GeneratedField.generated_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L67","symbol":"GeneratedField.generated_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.generated_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 54,
    "symbol": "GeneratedField.generated_sql"
  },
  "id": "7af27255-dd9b-4eb8-92b7-2694724101c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4325670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L67",
        "symbol": "GeneratedField.generated_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "05b0efbd-123b-4361-9275-50b10fa043ed",
  "subject_name": "django/db/models/fields/generated::GeneratedField.generated_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def generated_sql(self, connection)"
}
```
