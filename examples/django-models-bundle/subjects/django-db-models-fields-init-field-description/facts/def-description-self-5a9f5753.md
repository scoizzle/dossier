# Fact 5a9f5753

Store id: fc791210-8ac6-4be8-a728-4fc7d96be065

## Text

```text
def _description(self)
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
- posted_at: `2026-11-09T23:31:56.4164740+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 186,
  "symbol": "Field._description"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L189","symbol":"Field._description"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._description](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 186,
    "symbol": "Field._description"
  },
  "id": "fc791210-8ac6-4be8-a728-4fc7d96be065",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4164740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L189",
        "symbol": "Field._description"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "087d8935-8232-484d-bc5b-6bd82600bd34",
  "subject_name": "django/db/models/fields/__init__::Field._description",
  "tags": [
    "entity:method"
  ],
  "text": "def _description(self)"
}
```
