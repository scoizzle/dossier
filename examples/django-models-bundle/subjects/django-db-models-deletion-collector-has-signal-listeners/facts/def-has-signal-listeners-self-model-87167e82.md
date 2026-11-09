# Fact 87167e82

Store id: 6f1d27a5-e87d-4e51-a359-56c31b63aa7a

## Text

```text
def _has_signal_listeners(self, model)
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
- posted_at: `2026-11-09T22:39:41.0623370+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 205,
  "symbol": "Collector._has_signal_listeners"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":205,"selector":"L205-L208","symbol":"Collector._has_signal_listeners"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector._has_signal_listeners](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 205,
    "symbol": "Collector._has_signal_listeners"
  },
  "id": "6f1d27a5-e87d-4e51-a359-56c31b63aa7a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0623370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 205,
        "selector": "L205-L208",
        "symbol": "Collector._has_signal_listeners"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "5d96f863-739e-4da7-b084-0ef7f7ac5c0b",
  "subject_name": "django/db/models/deletion::Collector._has_signal_listeners",
  "tags": [
    "entity:method"
  ],
  "text": "def _has_signal_listeners(self, model)"
}
```
