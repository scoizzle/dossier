# Fact 99fe1645

Store id: e942e166-5e7f-46a9-a549-12eb24fc9e51

## Text

```text
def run_validators(self, value)
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
- posted_at: `2026-11-09T23:31:56.4679040+00:00`

## Data

```json
{
  "end_line": 836,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 822,
  "symbol": "Field.run_validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":822,"selector":"L822-L836","symbol":"Field.run_validators"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.run_validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 836,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 822,
    "symbol": "Field.run_validators"
  },
  "id": "e942e166-5e7f-46a9-a549-12eb24fc9e51",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4679040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 822,
        "selector": "L822-L836",
        "symbol": "Field.run_validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "97385059-7844-4a2b-8a66-f236deac506a",
  "subject_name": "django/db/models/fields/__init__::Field.run_validators",
  "tags": [
    "entity:method"
  ],
  "text": "def run_validators(self, value)"
}
```
