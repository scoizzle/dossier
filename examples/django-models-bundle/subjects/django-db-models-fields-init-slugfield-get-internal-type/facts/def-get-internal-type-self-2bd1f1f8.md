# Fact 2bd1f1f8

Store id: 0fc2eee5-b561-4379-85c8-e5079886669f

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
- posted_at: `2026-11-09T23:44:50.2308910+00:00`

## Data

```json
{
  "end_line": 2512,
  "entity_kind": "method",
  "parent": "SlugField",
  "start_line": 2511,
  "symbol": "SlugField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2511,"selector":"L2511-L2512","symbol":"SlugField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2512,
    "entity_kind": "method",
    "parent": "SlugField",
    "start_line": 2511,
    "symbol": "SlugField.get_internal_type"
  },
  "id": "0fc2eee5-b561-4379-85c8-e5079886669f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2308910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2511,
        "selector": "L2511-L2512",
        "symbol": "SlugField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3d3f35c6-29c2-4799-a6b8-c8ccaca51306",
  "subject_name": "django/db/models/fields/__init__::SlugField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
