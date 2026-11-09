# Fact ea490956

Store id: a583a944-f44e-4feb-8aaa-2839a9caa543

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:56.5793030+00:00`

## Data

```json
{
  "end_line": 1515,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1506,
  "symbol": "DateField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1506,"selector":"L1506-L1515","symbol":"DateField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1515,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1506,
    "symbol": "DateField.deconstruct"
  },
  "id": "a583a944-f44e-4feb-8aaa-2839a9caa543",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5793030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1506,
        "selector": "L1506-L1515",
        "symbol": "DateField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6f17816f-ec29-486e-80c3-a8dc64b7be81",
  "subject_name": "django/db/models/fields/__init__::DateField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
