# Fact c3182b43

Store id: dfb8a016-dd60-40e6-9287-3711ead771ee

## Text

```text
def _prepare(cls)
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
- posted_at: `2026-11-09T23:44:48.5209250+00:00`

## Data

```json
{
  "end_line": 451,
  "entity_kind": "method",
  "parent": "ModelBase",
  "start_line": 398,
  "symbol": "ModelBase._prepare"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":398,"selector":"L398-L451","symbol":"ModelBase._prepare"}`

## Items

```json
[
  {
    "text": "Create some methods once self._meta has been populated.",
    "locator": {
      "line": 399
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase._prepare](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 451,
    "entity_kind": "method",
    "parent": "ModelBase",
    "start_line": 398,
    "symbol": "ModelBase._prepare"
  },
  "id": "dfb8a016-dd60-40e6-9287-3711ead771ee",
  "items": [
    {
      "locator": {
        "line": 399
      },
      "text": "Create some methods once self._meta has been populated."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5209250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 398,
        "selector": "L398-L451",
        "symbol": "ModelBase._prepare"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "9cb62967-8694-4747-b364-256732b340a9",
  "subject_name": "django/db/models/base::ModelBase._prepare",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare(cls)"
}
```
