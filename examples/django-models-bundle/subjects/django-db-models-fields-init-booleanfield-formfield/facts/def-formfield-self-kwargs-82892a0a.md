# Fact 82892a0a

Store id: 8c7ea8c9-f4f0-4aef-a1e0-1911a2da6f90

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
- posted_at: `2026-11-09T22:39:42.3706900+00:00`

## Data

```json
{
  "end_line": 1243,
  "entity_kind": "method",
  "parent": "BooleanField",
  "start_line": 1233,
  "symbol": "BooleanField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1233,"selector":"L1233-L1243","symbol":"BooleanField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1243,
    "entity_kind": "method",
    "parent": "BooleanField",
    "start_line": 1233,
    "symbol": "BooleanField.formfield"
  },
  "id": "8c7ea8c9-f4f0-4aef-a1e0-1911a2da6f90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3706900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1233,
        "selector": "L1233-L1243",
        "symbol": "BooleanField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "32d17bb7-719c-44e4-a9d1-f36aa9a61688",
  "subject_name": "django/db/models/fields/__init__::BooleanField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
