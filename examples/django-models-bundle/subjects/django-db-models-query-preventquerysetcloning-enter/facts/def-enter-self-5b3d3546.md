# Fact 5b3d3546

Store id: 928cd561-87b8-4d92-89b5-09cdce44958e

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
- posted_at: `2026-11-09T23:32:04.2931150+00:00`

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
  "id": "928cd561-87b8-4d92-89b5-09cdce44958e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2931150+00:00"
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
  "subject_id": "8f3b9980-fd90-42f0-80a5-1d971bb5ed92",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__enter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __enter__(self)"
}
```
