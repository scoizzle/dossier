# Fact 6cf86ce8

Store id: 99a9025e-ba35-4702-ad49-c28744c7302b

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:49.9669230+00:00`

## Data

```json
{
  "end_line": 289,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 281,
  "symbol": "Field.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":281,"selector":"L281-L289","symbol":"Field.__str__"}`

## Items

```json
[
  {
    "text": "Return \"app_label.model_label.field_name\" for fields attached to models.",
    "locator": {
      "line": 282
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 289,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 281,
    "symbol": "Field.__str__"
  },
  "id": "99a9025e-ba35-4702-ad49-c28744c7302b",
  "items": [
    {
      "locator": {
        "line": 282
      },
      "text": "Return \"app_label.model_label.field_name\" for fields attached to models."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9669230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 281,
        "selector": "L281-L289",
        "symbol": "Field.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "50eb0737-a7ce-459c-84d4-85045a550912",
  "subject_name": "django/db/models/fields/__init__::Field.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
