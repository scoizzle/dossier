# Fact 68b133a3

Store id: 6ce40fd1-3da7-4e4c-8ba7-e0382cd3f2f3

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
- posted_at: `2026-11-09T22:39:50.3323310+00:00`

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
  "id": "6ce40fd1-3da7-4e4c-8ba7-e0382cd3f2f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.3323310+00:00"
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
  "subject_id": "4d064a78-803a-4086-b4fe-173dc2d4d23b",
  "subject_name": "django/db/models/signals::ModelSignal._lazy_method",
  "tags": [
    "entity:method"
  ],
  "text": "def _lazy_method(self, method, apps, receiver, sender, **kwargs)"
}
```
