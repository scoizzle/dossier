# Fact 6cf86ce8

Store id: 51d3c08f-6904-49ca-b462-799760f4cd41

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
- posted_at: `2026-11-09T22:39:42.2644560+00:00`

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
  "id": "51d3c08f-6904-49ca-b462-799760f4cd41",
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
    "posted_at": "2026-11-09T22:39:42.2644560+00:00"
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
  "subject_id": "d65de170-9bfd-46df-b1ec-53d6e71affa6",
  "subject_name": "django/db/models/fields/__init__::Field.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
