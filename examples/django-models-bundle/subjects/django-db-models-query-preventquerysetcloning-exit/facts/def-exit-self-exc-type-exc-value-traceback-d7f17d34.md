# Fact d7f17d34

Store id: 42589f6f-7aaf-4658-bf40-476f178e48b3

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
- posted_at: `2026-11-09T23:32:04.2960650+00:00`

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
  "id": "42589f6f-7aaf-4658-bf40-476f178e48b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2960650+00:00"
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
  "subject_id": "b4ae8160-d5fb-45d5-82fc-599c5bb21bb6",
  "subject_name": "django/db/models/query::PreventQuerySetCloning.__exit__",
  "tags": [
    "entity:method"
  ],
  "text": "def __exit__(self, exc_type, exc_value, traceback)"
}
```
