# Fact caf836e6

Store id: 7cec9bfd-76fc-4e36-ae34-5bd9c5420828

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T22:39:42.6437180+00:00`

## Data

```json
{
  "end_line": 2575,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2573,
  "symbol": "TextField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2573,"selector":"L2573-L2575","symbol":"TextField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2575,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2573,
    "symbol": "TextField.get_prep_value"
  },
  "id": "7cec9bfd-76fc-4e36-ae34-5bd9c5420828",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6437180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2573,
        "selector": "L2573-L2575",
        "symbol": "TextField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9b85a3e3-a7d9-4a49-8bec-4d18a2df2945",
  "subject_name": "django/db/models/fields/__init__::TextField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
