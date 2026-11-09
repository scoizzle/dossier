# Fact c92b739b

Store id: ae63cc3f-96b3-45d4-860d-a1cd34e3e69d

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
- posted_at: `2026-11-09T23:44:50.2369490+00:00`

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
  "id": "ae63cc3f-96b3-45d4-860d-a1cd34e3e69d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2369490+00:00"
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
  "subject_id": "a44f2c5f-9762-4e25-b198-b7062cb013c8",
  "subject_name": "django/db/models/fields/__init__::TextField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
