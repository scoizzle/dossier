# Fact 7c75d3a2

Store id: 2726efba-03b7-45be-a236-6bba1523c582

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T22:39:42.5166330+00:00`

## Data

```json
{
  "end_line": 2096,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2095,
  "symbol": "FilePathField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2095,"selector":"L2095-L2096","symbol":"FilePathField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2096,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2095,
    "symbol": "FilePathField.get_internal_type"
  },
  "id": "2726efba-03b7-45be-a236-6bba1523c582",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5166330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2095,
        "selector": "L2095-L2096",
        "symbol": "FilePathField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1871b86b-6011-497e-bb09-c7dbd76af824",
  "subject_name": "django/db/models/fields/__init__::FilePathField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
