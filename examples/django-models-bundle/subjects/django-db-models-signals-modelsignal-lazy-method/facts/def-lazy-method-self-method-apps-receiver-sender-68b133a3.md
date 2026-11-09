# Fact 68b133a3

Store id: 6a59c884-9e7c-4857-8ff7-2fb88a9bcb08

## Text

```text
def _lazy_method(self, method, apps, receiver, sender, **kwargs)
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
- posted_at: `2026-11-09T23:32:05.3767610+00:00`

## Data

```json
{
  "end_line": 24,
  "entity_kind": "method",
  "parent": "ModelSignal",
  "start_line": 15,
  "symbol": "ModelSignal._lazy_method"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/signals.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":15,"selector":"L15-L24","symbol":"ModelSignal._lazy_method"}`

## Referenced by

None.

## Subject

[django/db/models/signals::ModelSignal._lazy_method](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 24,
    "entity_kind": "method",
    "parent": "ModelSignal",
    "start_line": 15,
    "symbol": "ModelSignal._lazy_method"
  },
  "id": "6a59c884-9e7c-4857-8ff7-2fb88a9bcb08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.3767610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 15,
        "selector": "L15-L24",
        "symbol": "ModelSignal._lazy_method"
      },
      "rel": "derived_from",
      "target": "django/db/models/signals.py"
    }
  ],
  "status": "live",
  "subject_id": "757c5fe2-9c0b-4865-97b4-d1f6e078fc77",
  "subject_name": "django/db/models/signals::ModelSignal._lazy_method",
  "tags": [
    "entity:method"
  ],
  "text": "def _lazy_method(self, method, apps, receiver, sender, **kwargs)"
}
```
