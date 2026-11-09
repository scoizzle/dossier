# Fact d7f17d34

Store id: 4d597c51-e260-40cb-a04a-641f8450af22

## Text

```text
def __exit__(self, exc_type, exc_value, traceback)
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
- posted_at: `2026-11-09T22:39:49.2789880+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "method",
  "parent": "PreventQuerySetCloning",
  "start_line": 360,
  "symbol": "PreventQuerySetCloning.__exit__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":360,"selector":"L360-L361","symbol":"PreventQuerySetCloning.__exit__"}`

## Referenced by

None.

## Subject

[django/db/models/query::PreventQuerySetCloning.__exit__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "method",
    "parent": "PreventQuerySetCloning",
    "start_line": 360,
    "symbol": "PreventQuerySetCloning.__exit__"
  },
  "id": "4d597c51-e260-40cb-a04a-641f8450af22",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2789880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 360,
        "selector": "L360-L361",
        "symbol": "PreventQuerySetCloning.__exit__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8fe82764-95e9-42ae-a732-0a97d5b62d66",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__exit__",
  "tags": [
    "entity:method"
  ],
  "text": "def __exit__(self, exc_type, exc_value, traceback)"
}
```
