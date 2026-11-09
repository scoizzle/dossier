# Fact 77ecde2c

Store id: 5117478d-6cd9-4156-90c5-e2b1c5a30f93

## Text

```text
def slice_expression(self, expression, start, length)
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
- posted_at: `2026-11-09T22:39:42.3931520+00:00`

## Data

```json
{
  "end_line": 1362,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1359,
  "symbol": "CharField.slice_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1359,"selector":"L1359-L1362","symbol":"CharField.slice_expression"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.slice_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1362,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1359,
    "symbol": "CharField.slice_expression"
  },
  "id": "5117478d-6cd9-4156-90c5-e2b1c5a30f93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3931520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1359,
        "selector": "L1359-L1362",
        "symbol": "CharField.slice_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "af96d9f1-2962-45f8-92c3-a62caa1b7ac5",
  "subject_name": "django/db/models/fields/__init__::CharField.slice_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def slice_expression(self, expression, start, length)"
}
```
