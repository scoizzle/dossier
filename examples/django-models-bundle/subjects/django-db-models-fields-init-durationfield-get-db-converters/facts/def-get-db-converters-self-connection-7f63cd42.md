# Fact 7f63cd42

Store id: 4bf94944-35ce-47d2-a115-e9195fb3ed19

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:44:50.1328840+00:00`

## Data

```json
{
  "end_line": 1982,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1978,
  "symbol": "DurationField.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1978,"selector":"L1978-L1982","symbol":"DurationField.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1982,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1978,
    "symbol": "DurationField.get_db_converters"
  },
  "id": "4bf94944-35ce-47d2-a115-e9195fb3ed19",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1328840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1978,
        "selector": "L1978-L1982",
        "symbol": "DurationField.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3b2fa7bc-ec23-429d-a85d-ff34cde93f84",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
