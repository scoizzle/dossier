# Fact 67a366ef

Store id: 8cf258a6-f1bb-4136-99db-c5015eb525d0

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:44:50.1301810+00:00`

## Data

```json
{
  "end_line": 1973,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1956,
  "symbol": "DurationField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1956,"selector":"L1956-L1973","symbol":"DurationField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1973,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1956,
    "symbol": "DurationField.to_python"
  },
  "id": "8cf258a6-f1bb-4136-99db-c5015eb525d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1301810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1956,
        "selector": "L1956-L1973",
        "symbol": "DurationField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a614efbd-1b11-4b19-9aa3-2d8d46fb33f4",
  "subject_name": "django/db/models/fields/__init__::DurationField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
