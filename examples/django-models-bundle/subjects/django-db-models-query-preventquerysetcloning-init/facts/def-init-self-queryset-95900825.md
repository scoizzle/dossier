# Fact 95900825

Store id: 2464331f-aee3-4732-a7fc-4023e8c493bb

## Text

```text
def __init__(self, queryset)
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
- posted_at: `2026-11-09T22:39:49.2703310+00:00`

## Data

```json
{
  "end_line": 355,
  "entity_kind": "method",
  "parent": "PreventQuerySetCloning",
  "start_line": 354,
  "symbol": "PreventQuerySetCloning.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":354,"selector":"L354-L355","symbol":"PreventQuerySetCloning.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::PreventQuerySetCloning.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 355,
    "entity_kind": "method",
    "parent": "PreventQuerySetCloning",
    "start_line": 354,
    "symbol": "PreventQuerySetCloning.__init__"
  },
  "id": "2464331f-aee3-4732-a7fc-4023e8c493bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2703310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 354,
        "selector": "L354-L355",
        "symbol": "PreventQuerySetCloning.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "eb97d1f5-06d2-4ac3-a40f-758c2d3c47b4",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset)"
}
```
