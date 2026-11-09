# Fact eb7103c8

Store id: 014dd9d1-b918-423d-a6a2-de5514ab9944

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.6458770+00:00`

## Data

```json
{
  "end_line": 2587,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2577,
  "symbol": "TextField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2577,"selector":"L2577-L2587","symbol":"TextField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2587,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2577,
    "symbol": "TextField.formfield"
  },
  "id": "014dd9d1-b918-423d-a6a2-de5514ab9944",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6458770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2577,
        "selector": "L2577-L2587",
        "symbol": "TextField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a6e6a098-fc67-4ec0-909e-339b2f780f86",
  "subject_name": "django/db/models/fields/__init__::TextField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
