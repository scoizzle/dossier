# Fact 87167e82

Store id: 9105223d-670c-4134-b3b0-15c19c610413

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
- posted_at: `2026-11-09T23:44:48.9133520+00:00`

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
  "id": "9105223d-670c-4134-b3b0-15c19c610413",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9133520+00:00"
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
  "subject_id": "b34ee971-28ab-4a86-bfaa-fac537229521",
  "subject_name": "django/db/models/deletion::Collector._has_signal_listeners",
  "tags": [
    "entity:method"
  ],
  "text": "def _has_signal_listeners(self, model)"
}
```
