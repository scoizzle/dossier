# Fact b0838b86

Store id: 2b49814c-9939-4251-8a13-2b5568736089

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
- posted_at: `2026-11-09T22:39:42.3761410+00:00`

## Data

```json
{
  "end_line": 1266,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1260,
  "symbol": "CharField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1260,"selector":"L1260-L1266","symbol":"CharField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1266,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1260,
    "symbol": "CharField.check"
  },
  "id": "2b49814c-9939-4251-8a13-2b5568736089",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3761410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1260,
        "selector": "L1260-L1266",
        "symbol": "CharField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f5060ff8-eb38-41a5-a160-6275e3aade65",
  "subject_name": "django/db/models/fields/__init__::CharField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
