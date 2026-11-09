# Fact c92b739b

Store id: 34df12a8-a20a-4c8e-bec5-91833f5df418

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.6345350+00:00`

## Data

```json
{
  "end_line": 2536,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2531,
  "symbol": "TextField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2531,"selector":"L2531-L2536","symbol":"TextField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2536,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2531,
    "symbol": "TextField.check"
  },
  "id": "34df12a8-a20a-4c8e-bec5-91833f5df418",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6345350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2531,
        "selector": "L2531-L2536",
        "symbol": "TextField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d2fb151c-aaf0-4905-b1d0-f45ce3ecf1d8",
  "subject_name": "django/db/models/fields/__init__::TextField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
