# Fact 95900825

Store id: 196a9469-43bd-4731-9037-04f5820e988c

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
- posted_at: `2026-11-09T23:44:55.8165910+00:00`

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
  "id": "196a9469-43bd-4731-9037-04f5820e988c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8165910+00:00"
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
  "subject_id": "29fa5c59-d0a3-4f70-8c42-d583516c841a",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset)"
}
```
