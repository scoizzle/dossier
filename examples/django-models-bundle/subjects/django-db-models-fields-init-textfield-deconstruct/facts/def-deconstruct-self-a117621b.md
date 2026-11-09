# Fact a117621b

Store id: c156137f-21ff-40d0-9963-ae8e873bf3e7

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
- posted_at: `2026-11-09T23:31:56.8074380+00:00`

## Data

```json
{
  "end_line": 2593,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2589,
  "symbol": "TextField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2589,"selector":"L2589-L2593","symbol":"TextField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2593,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2589,
    "symbol": "TextField.deconstruct"
  },
  "id": "c156137f-21ff-40d0-9963-ae8e873bf3e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8074380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2589,
        "selector": "L2589-L2593",
        "symbol": "TextField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2d754f02-d9d4-416e-87c0-2e1ca7813838",
  "subject_name": "django/db/models/fields/__init__::TextField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
