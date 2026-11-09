# Fact 9fc815a8

Store id: 538bdba7-59ba-49e3-9b45-19d332a0a1d5

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:31:57.1461590+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 148,
  "symbol": "CompositePrimaryKey.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L156","symbol":"CompositePrimaryKey.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 148,
    "symbol": "CompositePrimaryKey.to_python"
  },
  "id": "538bdba7-59ba-49e3-9b45-19d332a0a1d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1461590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L156",
        "symbol": "CompositePrimaryKey.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "cda56904-28db-4d1c-bc53-35fc7205cbbf",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
