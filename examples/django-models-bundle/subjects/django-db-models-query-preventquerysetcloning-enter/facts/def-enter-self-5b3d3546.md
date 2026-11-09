# Fact 5b3d3546

Store id: d0ec762b-3789-4110-b0d2-de1b69f308ab

## Text

```text
def __enter__(self)
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
- posted_at: `2026-11-09T23:44:55.8191210+00:00`

## Data

```json
{
  "end_line": 358,
  "entity_kind": "method",
  "parent": "PreventQuerySetCloning",
  "start_line": 357,
  "symbol": "PreventQuerySetCloning.__enter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":357,"selector":"L357-L358","symbol":"PreventQuerySetCloning.__enter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::PreventQuerySetCloning.__enter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 358,
    "entity_kind": "method",
    "parent": "PreventQuerySetCloning",
    "start_line": 357,
    "symbol": "PreventQuerySetCloning.__enter__"
  },
  "id": "d0ec762b-3789-4110-b0d2-de1b69f308ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8191210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 357,
        "selector": "L357-L358",
        "symbol": "PreventQuerySetCloning.__enter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8925187d-498f-415d-99fc-2f91a154a560",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__enter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __enter__(self)"
}
```
